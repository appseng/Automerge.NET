using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Automerge.NET
{
    enum changes
    {
        deleted,
        unchanged,
        added
    }

    class Work
    {
        public string SourceInput { set; get; }
        public string Source1st { set; get; }
        public string Source2nd { set; get; }
        public string SourceOuput { set; get; }

        private List<string> lSourceInput = new List<string>();
        private List<string> lSource1st = new List<string>();
        private List<string> lSource2nd = new List<string>();
        private List<string> lSourceOuput = new List<string>();

        private List<string> lCnanges1st = new List<string>();
        private List<changes> l1stchanges = new List<changes>();
        private List<string> lCnanges2nd = new List<string>();
        private List<changes> l2ndchanges = new List<changes>();

        public void AutoMerge()
        {
            // check exsistance of source files
            if (!File.Exists(SourceInput) || !File.Exists(Source1st) || !File.Exists(Source2nd))
                return;

            // read source files in lists
            using (StreamReader srInput = new StreamReader(SourceInput))
            {
                while (!srInput.EndOfStream)
                    lSourceInput.Add(srInput.ReadLine());
            }

            using (StreamReader sr1st = new StreamReader(Source1st))
            {
                while (!sr1st.EndOfStream)
                    lSource1st.Add(sr1st.ReadLine());
            }

            using (StreamReader sr2nd = new StreamReader(Source2nd))
            {
                while (!sr2nd.EndOfStream)
                    lSource2nd.Add(sr2nd.ReadLine());
            }


            MergeN(lSource1st, l1stchanges, lCnanges1st);
            MergeN(lSource2nd, l2ndchanges, lCnanges2nd);

            MergeNext();

            //for(
            //foreach (var el in lCnanges1st)
            //    lSourceOuput.Add(el);

            // write data to output file
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lSourceOuput.Count - 1; i++)
            {
                sb.AppendLine(lSourceOuput[i]);
            }
            if (lSourceOuput.Count > 0)
                sb.Append(lSourceOuput[lSourceOuput.Count - 1]);

            FileStream fs = File.Open(SourceOuput, FileMode.Create);
            using (StreamWriter outfile = new StreamWriter(fs))
            {
                outfile.Write(sb.ToString());
            }
        }

        private void MergeN(List<string> sourceMod, List<changes> changesMod, List<string> stringMod)
        {
            // merge input source with sourceMod
            // obtain changesMod and stringMod
            int indexInput = 0;
            int indexChanges = 0;
            bool changed = false;
            for (int i = 0; i < sourceMod.Count; i++)
            {
                string str = sourceMod[i];
                if (changed)
                {
                    int j = 0;
                    bool sflag = false;
                    for (j = i; j < sourceMod.Count; j++)
                    {
                        //changed = true;
                        if (sourceMod[j].Trim() == lSourceInput[indexInput].Trim())
                        {// string is added
                            sflag = true;
                            break;
                        }
                    }
                    if (sflag) // multi string addition
                    {
                        int k = 0;
                        for (k = i - 1; k < j; k++)
                        {
                            changesMod.Add(changes.added);
                            stringMod.Add(sourceMod[k]);
                            indexChanges++;
                            //indexInput++;
                        }
                        changesMod.Add(changes.unchanged);// plus 1 unchanged string
                        stringMod.Add(sourceMod[j]);
                        indexChanges++;
                        indexInput++;
                        i = j;
                        changed = false;
                    }
                    else // string is deleted and added
                    {
                        int l = 0;
                        int k = 0;
                        bool jkflag = false;
                        for (l = indexInput; l < lSourceInput.Count; l++)
                        {
                            for (k = i; k < sourceMod.Count; k++)
                                if (sourceMod[k].Trim() == lSourceInput[l].Trim())
                                {
                                    jkflag = true;
                                    break;
                                }
                            if (jkflag)
                                break;
                        }
                        //if (jkflag)
                        //{
                            for (int n = indexInput; n < l; n++)
                            {
                                changesMod.Add(changes.deleted);
                                stringMod.Add(lSourceInput[n]);
                                indexChanges++;
                            }
                            indexInput = l;
                            for (int m = i - 1; m < k; m++)
                            {
                                changesMod.Add(changes.added);
                                stringMod.Add(sourceMod[m]);
                                indexChanges++;
                            }
                            i = k - 1;
                        //}
                        changed = false;
                    }

                }
                else
                {
                    if (indexInput < lSourceInput.Count && str.Trim() == lSourceInput[indexInput].Trim())
                    {// string is unchanged
                        changesMod.Add(changes.unchanged);
                        stringMod.Add(str);
                        indexChanges++;
                        indexInput++;
                    }
                    else
                    { // string is changed
                        changed = true;
                        int j = 0;
                        if (indexInput >= lSourceInput.Count)
                        {
                            changesMod.Add(changes.added);
                            stringMod.Add(str);
                            indexChanges++;
                            changed = false;
                        }
                        else
                        {

                            bool flag = false;
                            for (j = indexInput + 1; j < lSourceInput.Count; j++)// check is string deleted?
                            {
                                if (str.Trim() == lSourceInput[j].Trim())
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag)// check! is several strings deleted?
                            {
                                int k = 0;
                                for (k = indexInput; k < j; k++)
                                {
                                    changesMod.Add(changes.deleted);
                                    stringMod.Add(lSourceInput[k]);
                                    indexChanges++;
                                    //indexInput++;
                                }
                                changesMod.Add(changes.unchanged);
                                stringMod.Add(str);
                                indexChanges++;
                                indexInput = j + 1;
                                changed = false;
                                //deleted = true;
                            }
                            else if (i == sourceMod.Count - 1)
                            {
                                changesMod.Add(changes.deleted);
                                stringMod.Add(lSourceInput[indexInput]);
                                changesMod.Add(changes.added);
                                stringMod.Add(str);
                                indexChanges++;
                                indexInput++;
                            }
                        }
                    }
                }
            }
            if (indexInput < lSourceInput.Count)
            {
                for (int i = indexInput; i < lSourceInput.Count; i++)
                {
                    changesMod.Add(changes.deleted);
                    stringMod.Add(lSourceInput[i]);
                }
            }
        }

        private void MergeNext()
        {
            // merge 1st and 2nd stringMods
            int index1st = 0;
            int index2nd = 0;
            int indexOutput = 0;
            bool deleted1st = false;
            bool deleted2nd = false;
            while (index1st < lCnanges1st.Count && index2nd < lCnanges2nd.Count)
            {
                changes ch1st = l1stchanges[index1st];
                changes ch2nd = l2ndchanges[index2nd];
                string str1st = lCnanges1st[index1st];
                string str2nd = lCnanges2nd[index2nd];
                if (ch1st == ch2nd && ch1st == changes.unchanged && str1st.Trim() == str2nd.Trim())
                {
                    lSourceOuput.Add(str1st);
                    indexOutput++;
                    index1st++;
                    index2nd++;
                }
                else if (ch1st == changes.deleted && ch1st == ch2nd && str1st.Trim() == str2nd.Trim())
                {
                    index1st++;
                    index2nd++;
                    //deleted = true;
                }
                else if (ch1st == changes.added && ch1st == ch2nd && str1st.Trim() != str2nd.Trim())
                {
                    if (deleted2nd)
                    {
                        lSourceOuput.Add(str2nd);
                        lSourceOuput.Add(str1st);
                        indexOutput += 2;
                        deleted2nd = false;
                    }
                    else if (deleted1st)
                    {
                        lSourceOuput.Add(str1st);
                        lSourceOuput.Add(str2nd);
                        indexOutput += 2;
                        deleted1st = false;
                    }
                    else
                    {
                        lSourceOuput.Add("Конфликт строк");
                        indexOutput++;
                    }
                    index1st++;
                    index2nd++;
                }
                else if (ch1st == changes.added && ch1st == ch2nd && str1st.Trim() == str2nd.Trim())
                {
                    lSourceOuput.Add(str1st);
                    index1st++;
                    index2nd++;
                    indexOutput++;
                }
                else if (ch1st == changes.added && ch2nd == changes.unchanged)
                {
                    lSourceOuput.Add(str1st);
                    index1st++;
                    //index2nd++;
                    indexOutput++;
                }
                else if (ch2nd == changes.added && ch1st == changes.unchanged)
                {
                    lSourceOuput.Add(str2nd);
                    //index1st++;
                    index2nd++;
                    indexOutput++;
                }
                else if (ch1st == changes.unchanged && ch2nd == changes.deleted && str1st.Trim() == str2nd.Trim())
                {
                    index1st++;
                    index2nd++;
                    deleted2nd = true;
                    continue;
                }
                else if (ch1st == changes.deleted && ch2nd == changes.unchanged && str1st.Trim() == str2nd.Trim())
                {
                    index1st++;
                    index2nd++;
                    deleted1st = true;
                    continue;
                }
                else if (ch1st == changes.added && ch2nd == changes.deleted)
                {
                    lSourceOuput.Add(str1st);
                    index1st++;
                    //index2nd++;
                    indexOutput++;
                }
                else if (ch1st == changes.deleted && ch2nd == changes.added)
                {
                    lSourceOuput.Add(str2nd);
                    index2nd++;
                    indexOutput++;
                }
                else
                {
                    lSourceOuput.Add("Обработчик такой ситуации слияния пока не предусмотрен");
                    index1st++;
                    index2nd++;
                }
                deleted1st = false;
                deleted2nd = false;
            }
            if (index1st < lCnanges1st.Count)
            {
                for (int i = index1st; i < lCnanges1st.Count; i++)
                {
                    if (l1stchanges[i] == changes.added)
                        lSourceOuput.Add(lCnanges1st[i]);
                }
            }
            else if (index2nd < lCnanges2nd.Count)
            {
                for (int i = index2nd; i < lCnanges2nd.Count; i++)
                {
                    if (l2ndchanges[i] == changes.added)
                        lSourceOuput.Add(lCnanges2nd[i]);
                }
            }
        }
        //MergeNext()
    }
}

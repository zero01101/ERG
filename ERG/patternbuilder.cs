using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ERG
{
    class patternbuilder
    {
        private ArrayList pattern, counts, remainders;
        private StringBuilder log;
        string recursionlevel;
        string logstring;

        public patternbuilder()
        {
            pattern = new ArrayList();
            counts = new ArrayList();
            remainders = new ArrayList();
            log = new StringBuilder();            
        }

        public string ERG(int r, int p)
        {
            recursionlevel = "-"; 
            log.AppendLine("started with " + r.ToString() + " resolution and " + p.ToString() + " pulses"); 
            return ERGr(r, p);
        }

        private string ERGr(int resolution, int pulses)
        {            
            pattern.Clear();
            counts.Clear();
            remainders.Clear();
            log.AppendLine("arraylists cleared"); 
            int res = resolution; 
            int pls = pulses; 
            int divisor = res - pls;
            log.AppendLine("divisor set to " + divisor.ToString() + " via resolution minus pulses (" + res.ToString() + " - " + pls.ToString() + ")"); 

            remainders.Add(pls);
            log.AppendLine("added " + pls.ToString() + " to remainders");  
            string remaindersstring = pls.ToString() + " "; 
            string countsstring = ""; 
            
            int level = 0;
            log.AppendLine("set level to 0"); 

            log.AppendLine("entering begin loop"); 
            if (pls != 0)
            {
                log.AppendLine("pulses was not equal to zero - stay in distributor loop");  
                while (true)
                {
                    log.AppendLine("while true"); 
                    counts.Add(divisor / (int)remainders[level]);
                    countsstring += (divisor / (int)remainders[level]).ToString() + " "; 
                    log.AppendLine("added divisor / remainders[level] to counts - " + (divisor / (int)remainders[level]).ToString() + " - where divisor is " + divisor.ToString() + ", level is " + level.ToString() + " and remainders[level] is " + remainders[level].ToString() + " - counts are " + countsstring); 
                    
                    remainders.Add(divisor % (int)remainders[level]);
                    remaindersstring += (divisor % (int)remainders[level]).ToString() + " "; 
                    log.AppendLine("added divisor % remainders[level] to remainders - " + (divisor % (int)remainders[level]).ToString() + " - where divisor is " + divisor.ToString() + ", level is " + level.ToString() + " and remainders[level] is " + remainders[level].ToString() + " - remainders are " + remaindersstring); 
                    divisor = (int)remainders[level];
                    log.AppendLine("divisor is now " + divisor.ToString() + " - from remainders[level]"); 
            
                    level++;
                    log.AppendLine("level is now " + level.ToString() + " - from level++"); 

                    if ((int)remainders[level] <= 1) break;
                    log.AppendLine("remainders[level] !<= 1, looping back to while true"); 
                }
            }

            counts.Add(divisor);
            countsstring += divisor.ToString() + " "; 
            log.AppendLine("added divisor (" + divisor.ToString() + ") to counts - counts is now " + countsstring); 
            
            build(level);
            
            string outs = "";
            logstring = log.ToString();
            log.Clear();

            for (int i = pattern.Count; i > 0; i--)
            {
                outs += pattern[i - 1]; //pattern is backwards to start; write the outs in reverse
            }

            if (outs.Substring(0, 1) == "1")
            {
                return outs; //starts on a beat; euclidean rhythms are cyclical so actual position is aesthetic and we have offset
            }
            else
            {
                if (outs.Contains("1")) //faster than a try catch loop for trying to use indexof("1")
                {
                    int first1 = outs.IndexOf("1");
                    outs = outs.Substring(first1, outs.Length - first1) + outs.Substring(0, first1);
                    return outs;
                }
                else
                {
                    return outs;  //0s, 0s all the way down
                }
            }
        }

        private void build(int level)  //fuck i don't understand recursion at all
        {            
            string internalrecursionlevel = "|"; 
            if (level == -1)
            {
                log.AppendLine(recursionlevel + internalrecursionlevel + " level == -1, adding 0 to pattern"); 
                pattern.Add(0);
            }
            else if (level == -2)
            {
                log.AppendLine(recursionlevel + internalrecursionlevel + " level == -2, adding 1 to pattern"); 
                pattern.Add(1);
            }
            else
            {
                log.AppendLine(recursionlevel + " level >= 0, loop entry"); 
                for (int i = 0; i < (int)counts[level]; i++)                
                {
                    log.AppendLine(recursionlevel + internalrecursionlevel + " build(" + (level - 1).ToString() + ") " + (i + 1).ToString() + " of " + counts[level].ToString()); 
                    internalrecursionlevel += "|"; 
                    build(level - 1);
                }
                if ((int)remainders[level] != 0)
                {
                    log.AppendLine(recursionlevel + internalrecursionlevel + " remainders[level] != 0) - build(" + (level - 2).ToString() + ")"); 
                    internalrecursionlevel += "|"; 
                    build(level - 2);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    public class BigInteger
    {
        public Part head;
        public bool is_negative = false;
        
        public BigInteger()
        {
            head = new Part();
        }
        public BigInteger(int i)
        {
            head = new Part();
            new Part(head, i);
        }
        public void AddAfter(Part part, Part new_part)
        {
            part.Next = new_part;
        }
        public void AddHead(Part new_head)
        {
            if (head.Next != null)
                new_head.Next = head.Next;
            head.Next = new_head;
        }
        public BigInteger smooth()
        {
            Part help_head = head;
            Part cur = head;
            while (cur.Next != null)
            {
                cur = cur.Next;
                if (cur.value != 0)
                    help_head = cur;              
            }
            help_head.Next = null;
            return this;
        }
        public IEnumerator<Part> GetEnumerator()
        {
            BigInteger ans = GetReversed();
            Part cur = ans.head;
            while (cur.Next != null)
            {
                cur = cur.Next;
                yield return cur;
            }
        }
        private BigInteger GetReversed()
        {
            BigInteger ans = new BigInteger();
            Part tmp = this.head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
                ans.AddHead(new Part(tmp.value));
            }
            return ans;
        }

        public int Length()
        {
            int cnt = 0;
            Part cur = this.head;
            while (cur.Next != null)
            {
                cur = cur.Next;
                cnt++;
            }
            return cnt;
        }
        public override string ToString()
        {
            string ans = "";
            Part cur = this.head;
            while (cur.Next != null)
            {
                cur = cur.Next;
                ans = cur.value + ans;
                for (int i = 0; 4 - cur.ToString().Length > i; i++) { ans = "0" + ans; }
            }
            try 
            {
                int k = 0;
                while (ans[k] == '0') { k++; }
                ans = ans.Substring(k);
                ans = (this.is_negative ? "-" : "") + ans;              
            }
            catch (IndexOutOfRangeException)
            {
                ans = "0";
            }    
            return ans;
        }
    }
    public class Part
    {
        public Part Next;  
        public int value = 0;

        public Part() { }
        public Part(int i)
        {
            this.value = i;
        }
        public Part(Part p)
        {
            p.Next = this;
        }
        public Part(Part p, int i)
        {
            this.value = i;
            p.Next = this;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}

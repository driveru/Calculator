using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    public class BigInteger
    {
        public Part head;
        public bool is_negative;
        
        public BigInteger()
        {
            this.head = new Part();
        }
        public void AddAfter(Part part, Part new_part)
        {
            part.Next = new_part;
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
            string ans = this.is_negative ? "-" : "";
            Part cur = this.head;
            while (cur.Next != null)
            {
                cur = cur.Next;
                ans = cur + ans;
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
        public override string ToString()
        {
            return value.ToString();
        }
        public static Part operator +(Part p1, Part p2)
        {
            return new Part(p1.value + p2.value);
        }
        public static Part operator -(Part p1, Part p2)
        {
            return new Part(p1.value - p2.value);
        }
        public static Part operator *(Part p1, Part p2)
        {
            return new Part(p1.value * p2.value);
        }
    }
}

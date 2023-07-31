using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class ArrayDelegates
    {
        delegate void DelOp(int x, int y); 
        public static void SingleCastDelegate()
        {
            DelOp[] op =
            {
                new DelOp(Operation.Add),
                new DelOp(Operation.Sub)
            };
            for(int i = 0; i < op.Length; i++)
            {
                op[i](1, 2);
                op[i](44, 88);
                op[i](100, 50);
            }
        }
        public static void MultiCastDelegate()
        {
            DelOp op = Operation.Add;
            op += Operation.Sub; 
            op(2, 1);
            op(7, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazariBelirleme
{
    internal class Stack : IStack
    {
        Node top;

        public Stack()
        {
            this.top = null;
        }

        public void Push(object item)
        {
            Node newNode = new Node(item);
            if (top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = top;
            }
            top = newNode;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.Data);
            top = top.Next;
        }

        public object Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Boş.");
                return null;
            }

            Console.WriteLine("{0} is on the top of Stack", top.Data);
            return top.Data;
        }

        public void DisplayElements()
        {
            if (top == null)
            {
                MessageBox.Show("Stack Boş");
                return;
            }
            else
            {
                Node Temp = top;
                while (Temp != null)
                {

                    MessageBox.Show((string)Temp.Data);

                    Temp = Temp.Next;
                }
            }
        }






    }
}

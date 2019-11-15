using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            DeleteAll();
        }



        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        #region publicMethods
        public void Add(T data)
        {
            var item = new Item<T>(data);

            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }


        public void Delete(T data)
        {

            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {

                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        public void InsertAfter(T target, T data)
        {

            if (Head != null)
            {


                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;

                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                //TODO
            }
        }

        public void Clear()
        {
            DeleteAll();
        }

        #endregion

        #region privateMethods
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        private void DeleteAll()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        #endregion

    }
}

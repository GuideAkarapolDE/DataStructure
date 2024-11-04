using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lists
{
    public class SinglyLinkedList : List
    {

        private class LinkedNode
        {
            public object e;
            public LinkedNode next;
            public LinkedNode(object e, LinkedNode next) //Constructor
            {
                this.e = e;
                this.next = next;
            }
        }
        //กำหนด first Node โดยให้ค่าเริ่มต้นเป็น null ทั้งซ้าย (e) และขวา (pointer)
        private LinkedNode first = new LinkedNode(null, null); //สร้าง Header
        private int SIZE;
        private LinkedNode nodeAt(int index) //Get node จาก Index ที่ให้
        {
            LinkedNode node = first; //first = header ใช้ first.next อาจเป็น null ก็ได้
            for (int i = -1; i < index; i++) //i = -1 (Header)
            {
                node = node.next;
            }
            return node;
        }
        public void add(int index, object e)
        {
            if (index <= SIZE)
            {
                LinkedNode node = nodeAt(index - 1); //Node ก่อนหน้าที่จะแทรก (Ant)
                node.next = new LinkedNode(e, node.next); //node.next = bat --> ทั้งก้อน new = cat
                SIZE++;
            }
        }
        public void add(object e)
        {
            add(SIZE, e);
        }

        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        public object get(int index)
        {
            return nodeAt(index).e;
        }

        public int indexOf(object e)
        {
            LinkedNode node = first.next; // เริ่มต้นที่โหนดแรก
            for (int i = 0; i < SIZE; i++)
            {
                if ((e == null && node.e == null) || (e != null && e.Equals(node.e)))
                {
                    return i; // หากพบค่า ให้ส่งคืน index
                }
                node = node.next; // ไปยังโหนดถัดไป
            }
            return -1; // หากไม่พบ ให้คืนค่า -1 (Header)
        }

        public bool isEmpty()
        {
            return first.next == null;
        }
        private void removeAfter(LinkedNode node)
        {
            if (node.next != null)
            {
                node.next = node.next.next; //โยงข้าม
                SIZE--;
            }

        }
        public void remove(int index)
        {
            LinkedNode node = nodeAt(index - 1); //ต้องหาตัวก่อนหน้าก่อน
            removeAfter(node);
        }

        public void remove(object e)
        {
            LinkedNode node = first;
            while (node.next != null && !node.next.e.Equals(e))
                node = node.next;
            removeAfter(node);
        }

        public void set(int index, object e)
        {
            nodeAt(index).e = e;
        }

        public int size()
        {
            return SIZE;
        }
    }
}
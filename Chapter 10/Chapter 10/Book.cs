using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_10
{
    public class Book : Product, ICrudActions
    {
        public int Author
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int DatePublished
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int ISBN
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Publisher
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int UniqueId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string SKU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
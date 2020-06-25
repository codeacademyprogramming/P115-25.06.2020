using System;
using System.Collections.Generic;
using System.Text;

namespace _250620
{
    interface IGun
    {
        bool Shoot();
        bool Reload();
        void ChangeMode();
        void AddPistol(int pistol);
    }

    interface IZoomable
    {
        void ZoomIn();
        void ZoomOut();
    }

    class Ak47 : IGun
    {
        public void AddPistol(int pistol)
        {
            throw new NotImplementedException();
        }

        public void ChangeMode()
        {
            throw new NotImplementedException();
        }

        public bool Reload()
        {
            throw new NotImplementedException();
        }

        public bool Shoot()
        {
            throw new NotImplementedException();
        }
    }

    class M416 : IGun, IZoomable
    {
        public void AddPistol(int pistol)
        {
            throw new NotImplementedException();
        }

        public void ChangeMode()
        {
            throw new NotImplementedException();
        }

        public bool Reload()
        {
            throw new NotImplementedException();
        }

        public bool Shoot()
        {
            throw new NotImplementedException();
        }

        public void ZoomIn()
        {
            throw new NotImplementedException();
        }

        public void ZoomOut()
        {
            throw new NotImplementedException();
        }

        void IGun.AddPistol(int pistol)
        {
            throw new NotImplementedException();
        }

        void IGun.ChangeMode()
        {
            throw new NotImplementedException();
        }

        bool IGun.Reload()
        {
            throw new NotImplementedException();
        }

        bool IGun.Shoot()
        {
            throw new NotImplementedException();
        }
    }
}

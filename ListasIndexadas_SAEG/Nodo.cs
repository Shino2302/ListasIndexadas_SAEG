using System;

namespace ListasIndexadas_SAEG
{
    public class Nodo
    {
        //alt + 95 = _
        private int _dato;
        private Nodo _siguiente;

        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set{ _siguiente = value; }
        }

    }
}

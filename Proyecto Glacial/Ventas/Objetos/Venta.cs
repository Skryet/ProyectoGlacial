using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class Venta
    {
        private int _idCliente;
        private double _subtotal;
        private double _descuento;
        private double _iva;
        private double _total;
        private DateTime _fecha;

        public Venta()
        {
            _idCliente = 0;
            _subtotal = 0;
            _descuento = 0;
            _iva = 0;
            _total = 0;
            _fecha = new DateTime();
        }

        public int idCliente { get { return _idCliente; } set { _idCliente = value; } }        

        public double Subtotal{get { return _subtotal; } set { _subtotal = value; } }

        public double Descuento { get { return _descuento; } set { _descuento = value; } }

        public double IVA { get { return _iva; } set { _iva = value; } }

        public double Total { get { return _total; } set { _total = value; } }

        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }        
    }
}

using EjercicioDecorador.Interface;
using System;

namespace EjercicioDecorador
{
    class ComponenteConcreto : CGuardarCXP
    {  
        public override string GuardarCXP(string _cid, string _cimporte, string _cnaturaleza)
        {
            return $"Identificador: {_cid},Importe Total: {_cimporte}, Naturaleza: {_cnaturaleza} ";
        }
    }
}

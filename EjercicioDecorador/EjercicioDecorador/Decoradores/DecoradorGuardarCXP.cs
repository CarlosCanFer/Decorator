using EjercicioDecorador.Interface;
using System;

namespace EjercicioDecorador
{
    class DecoradorGuardarCXP : Decorador
    {
       
        public DecoradorGuardarCXP(CGuardarCXP comp): base(comp)
        {           
        }

        public override string GuardarCXP(string _cid, string _cimporte, string _cnaturaleza)
        {
            return $"Se guarda CXP({base.GuardarCXP( _cid,  _cimporte,  _cnaturaleza)})";
        }            
    }
}

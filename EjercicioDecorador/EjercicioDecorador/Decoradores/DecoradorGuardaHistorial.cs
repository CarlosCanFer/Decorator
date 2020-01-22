using EjercicioDecorador.Interface;

namespace EjercicioDecorador
{
    class DecoradorGuardaHistorial : Decorador
    {
       public DecoradorGuardaHistorial(CGuardarCXP comp): base(comp){            
        }
        public override string GuardarCXP(string _cid, string _cimporte, string _cnaturaleza)
        {
           return $"Guardado en el historial({base.GuardarCXP( _cid,  _cimporte,  _cnaturaleza)}) " ;
        }              
    }
}

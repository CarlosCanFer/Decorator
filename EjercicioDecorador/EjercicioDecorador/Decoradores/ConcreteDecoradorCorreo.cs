using EjercicioDecorador.Interface;

namespace EjercicioDecorador
{
    class ConcreteDecoradorCorreo : Decorador
    {
        public ConcreteDecoradorCorreo(CGuardarCXP comp):base(comp)
        {            
        }
        public override string GuardarCXP(string _cid, string _cimporte, string _cnaturaleza)
        {
            return $"Correo enviado({base.GuardarCXP( _cid, _cimporte, _cnaturaleza)})";
        }  
    }
}

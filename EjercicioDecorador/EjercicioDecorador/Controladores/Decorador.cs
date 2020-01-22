using EjercicioDecorador.Interface;

namespace EjercicioDecorador
{
    abstract class Decorador : CGuardarCXP
    {
        protected CGuardarCXP _comp;       

        public Decorador(CGuardarCXP comp)
        {
            this._comp = comp;
        }

        public void ConjuntoComponentes(CGuardarCXP comp)
        {
            this._comp = comp;
        }
       
        public override string GuardarCXP(string _cid, string _cimporte, string _cnaturaleza)
        {

            if (this._comp != null)
            {
                return this._comp.GuardarCXP(_cid, _cimporte, _cnaturaleza);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

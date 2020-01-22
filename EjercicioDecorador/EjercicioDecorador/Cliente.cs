using EjercicioDecorador.Interface;
using System;
namespace EjercicioDecorador
{
    public class Cliente
    {
        public void ClienteCode(string _cid, string _cimporte, string _cnaturaleza)
        {
            var simple = new ComponenteConcreto();

            DecoradorGuardaHistorial guardaHistorial = new DecoradorGuardaHistorial(simple);            
            DecoradorGuardarCXP guardarCXP = new DecoradorGuardarCXP(guardaHistorial);          
            ConcreteDecoradorCorreo correoElectronico = new ConcreteDecoradorCorreo(guardarCXP);

            Console.WriteLine(correoElectronico.GuardarCXP(_cid, _cimporte, _cnaturaleza));
        }
    }
}

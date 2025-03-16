using System;
using System.Collections.Generic;

namespace PuentesMadison
{
    public class Puente
    {
        private List<char> _estructura;

        public List<char> Estructura
        {
            get => _estructura;
            set => _estructura = ValidarEstructura(value);
        }

        private List<char> ValidarEstructura(List<char> estructura)
        {
            if (!EsSimetrico(estructura))
            {
                throw new ArgumentException("INVALIDO");
            }
            if (!BasesEnExtremos(estructura))
            {
                throw new ArgumentException("INVALIDO");
            }
            return estructura;
        }

        private bool EsSimetrico(List<char> estructura)
        {
            int n = estructura.Count;
            for (int i = 0; i < n / 2; i++)
            {
                if (estructura[i] != estructura[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private bool BasesEnExtremos(List<char> estructura)
        {
            return estructura.Count > 1 && estructura[0] == '*' && estructura[^1] == '*';
        }

        public Puente(List<char> estructura)
        {
            _estructura = ValidarEstructura(estructura);
        }
    }
}
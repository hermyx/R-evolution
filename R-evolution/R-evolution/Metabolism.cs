using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R_evolution
{
    public class Metabolism
    {
        public Enum_food_source _enum_food_source
        {
            get;
            set;
        }
        public Enum_electron_source _enum_electron_source
        {
            get;
            set;
        }
        public Enum_energy_source _enum_energy_source
        {
            get;
            set;
        }
        public int _code
        {
            get;
            set;
        }
        
        public Metabolism()
        {
            _code = 0;
            update_enums();
        }

        public Metabolism(int code)
        {
            if (code < 0 || code > 7)
                throw new CodeNotCorrectException();
            else
            {
                _code = code;
                update_enums();
            }
        }

        private void update_enums()
        {
            if( (_code/2) < 4) 
                _enum_energy_source = Enum_energy_source.Phototrophy;
            else
                _enum_energy_source = Enum_energy_source.Chimiotrophy;
            if ((_code) == 0 || (_code) == 1 || (_code) == 5 || (_code) == 6)
                _enum_electron_source = Enum_electron_source.Organotrophy;
            else
                _enum_electron_source = Enum_electron_source.Litotrophy;

            if ( (_code % 2) == 0)
                _enum_food_source = Enum_food_source.Heterotrophy;
            else
                _enum_food_source = Enum_food_source.Autotrophy;

        }
        
    }
}

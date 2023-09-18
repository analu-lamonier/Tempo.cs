using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTime
{
    internal class Time
    {
        int hora;
        int min;
        int segs;

        public int Hora { get => hora; set => hora = value; }
        public int Min { get => min; set => min = value; }
        public int Segs { get => segs; set => segs = value; }

        public Time(int _hora, int _min, int _segs)
        {
            hora = _hora;
            min = _min;
            segs = _segs;
        }

        public Time()
        {
            hora = 0;
            min = 0;
            segs = 0;
        }



        public void Horas()
        {
            Console.WriteLine("\n\rA hora Digitada é:" + hora + ":" + Min + ":" + segs + "s");
            //Console.WriteLine($"\n\rA hora atual é: {temp.hora}:{temp.min}:{temp.segs}s");

        }

        public TimeSpan SomadasHoras(Time hot)
        {
            double horaT = (hora + hot.hora) * 3600;
            double MinT = (min + hot.Min) * 60;
            double segsT = segs + hot.segs;

            var timeFinal = TimeSpan.FromSeconds((horaT + MinT + segsT));

            return timeFinal;
        }

        public TimeSpan SubtracaoHoras(Time hot)
        {
            double horaT = Math.Abs(hora - hot.hora) * 3600;
            double MinT = Math.Abs(min - hot.Min) * 60;
            double segsT = Math.Abs(segs - hot.segs);

            var timeFinal = TimeSpan.FromSeconds((horaT + MinT + segsT));

            return timeFinal;
        }
    }
}

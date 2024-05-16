using PruebaML;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PruebaML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load sample data (Carga de datos de ejemplo).
            var SampleData = new ML.ModelInput()
            {
                Gender = @"Female",
                Age = 54F,
                Hypertension = 0F,
                Heart_disease = 0F,
                Smoking_history = @"No Info",
                Bmi = 27.32F,
                HbA1c_level = 6.6F,
                Blood_glucose_level = 80F,
            };

            // Load model and predict output (Carga de modelo y salida).
            var Result = ML.Predict(SampleData);
            var Resultado = Result.Score * 100;
            Console.WriteLine("Probablidiad " + Resultado + "%");
        }
    }
}
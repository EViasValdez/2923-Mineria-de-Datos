﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace PruebaML
{
    public partial class ML
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(@"gender", @"gender", outputKind: OneHotEncodingEstimator.OutputKind.Indicator)      
                .Append(mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"age", @"age"),new InputOutputColumnPair(@"hypertension", @"hypertension"),new InputOutputColumnPair(@"heart_disease", @"heart_disease"),new InputOutputColumnPair(@"bmi", @"bmi"),new InputOutputColumnPair(@"HbA1c_level", @"HbA1c_level"),new InputOutputColumnPair(@"blood_glucose_level", @"blood_glucose_level")}))      
                .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"smoking_history",outputColumnName:@"smoking_history"))      
                .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"gender",@"age",@"hypertension",@"heart_disease",@"bmi",@"HbA1c_level",@"blood_glucose_level",@"smoking_history"}))      
                .Append(mlContext.Regression.Trainers.FastForest(new FastForestRegressionTrainer.Options(){NumberOfTrees=4,NumberOfLeaves=4,FeatureFraction=1F,LabelColumnName=@"diabetes",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
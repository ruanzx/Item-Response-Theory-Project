﻿using System.Collections.Generic;

namespace ExecutableIrt.ExcelInteraction.DataObjects
{
    public class SettingsInput
    {
        public int MinimumNumberOfQuestions;
        public int MaximumNumberOfQuestions;
        public double SeeCutoff;
        public double InformationCutoff;
        public List<double> IncreasingZeroVarianceStepsize;
        public List<double> DecreasingZeroVarianceStepsize;
        public List<double> StartingThetaList;
        public int NumQuestionsBeforeCatBegins;
        public double MistakeProbability;
        public bool UseDiscriminationParamForEstimation;
    }
}

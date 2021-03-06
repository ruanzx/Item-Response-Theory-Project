﻿using System.Collections.Generic;
using IRT.Mathematics;
using IRT.ModelParameters;

namespace IRT.ThetaEstimation
{
    public class MaximumLikelihoodEstimator
    {
        private readonly List<IModelParameters> _modelParametersList;

        public MaximumLikelihoodEstimator(List<IModelParameters> modelParametersList)
        {
            _modelParametersList = modelParametersList;
        }

        public double GetMle(List<int> responseVector)
        {
            LogLikelihoodFunction logLikelihoodFunction = new LogLikelihoodFunction(_modelParametersList);

            //const double initialGuess = 0;
            OneDimensionalFunction function = x => logLikelihoodFunction.LogLikelihood(responseVector, x);
            OneDimensionalFunction firstDerivativeFunction = x => logLikelihoodFunction.LogLikelihoodFirstDerivative(responseVector, x);
            //OneDimensionalFunction secondDerivativeFunction = x => logLikelihoodFunction.LogLikelihoodSecondDerivative(responseVector, x);
            //NewtonRhapsonSolver rootSolver = new NewtonRhapsonSolver(firstDerivativeFunction, secondDerivativeFunction, initialGuess);
            //BisectionSolver rootSolver = new BisectionSolver(firstDerivativeFunction, -6, 6);

            //double mle = rootSolver.FindRoot();
            //double mle = rootSolver.FindRoot();

            GlobalMaximizer globalMaximizer = new GlobalMaximizer(function, firstDerivativeFunction, -6, 6);
            var mle = globalMaximizer.FindPosOfMaximum();

            return mle;
        }
    }
}


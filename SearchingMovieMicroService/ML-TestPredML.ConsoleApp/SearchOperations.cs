using System;
using System.Collections.Generic;
using System.Linq;
using ML_TestPredML.Model;

namespace ML_TestPredML.ConsoleApp
{
    public class SearchOperations
    {

      

        public static float Prediction(ModelInput data)
        {
            var predictionResult = ConsumeModel.Predict(data);
            return predictionResult.Score;
        }

        public static List<int> RecommendedMoviesIdByCategory(float userId, List<int> moviesId)
        {
            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < moviesId.Count; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderByDescending(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add((int)prediction.Key);
            }
            return moviesId;
        }

        public static List<int> RecommendMoviesIdByKeyword(float userId, List<int> moviesIdTag, List<int> moviesIdTitle)
        {
            List<int> moviesIdRecommendedUsingTag = RecommendedMoviesIdByTag(userId, moviesIdTag);
            List<int> moviesIdRecommendedUsingTitle = RecommendedMoviesIdByTitle(userId,  moviesIdTitle);
            List<int> finalMoviesId = new List<int>();
            int k = 0;
            for(int i = 0; i < moviesIdRecommendedUsingTag.Count + moviesIdRecommendedUsingTitle.Count; i++)
            {

                if(i < moviesIdRecommendedUsingTitle.Count)
                {
                    finalMoviesId.Add(moviesIdRecommendedUsingTitle[i]);
                }
                else
                {
                    finalMoviesId.Add(moviesIdRecommendedUsingTag[k++]);
                }

            }
            return finalMoviesId;
        }

        public static List<int> RecommendedMoviesIdByTag(float userId, List<int> moviesId)
        {

            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < moviesId.Count; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderByDescending(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add((int)prediction.Key);
            }
            return moviesId;

        }
        public static List<int> RecommendedMoviesIdByTitle(float userId, List<int> moviesId)
        {

            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < moviesId.Count; i++)
            {
                ModelInput data = new ModelInput()
                {
                    UserId = userId,
                    MovieId = moviesId[i],
                };
                float predict = Prediction(data);
                if (!predictions.ContainsKey(moviesId[i]))
                {
                    predictions.Add(moviesId[i], predict);
                }
            }
            var sortedPredictions = predictions.OrderByDescending(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add((int)prediction.Key);
            }
            return moviesId;
        }
    }
}

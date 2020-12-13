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
            for (int i = 0; i < 15; i++)
            {
                if (moviesId.Count == i)
                {
                    if(i == 0)
                    {
                        return null;
                    } else
                    {
                        break;
                    }
                    
                }
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
            Random random = new Random();
            for(int i = 0; i < 15; i++)
            {
                int randomNumber = random.Next(2);
                if(randomNumber == 0)
                {
                    if(moviesIdRecommendedUsingTag != null && moviesIdRecommendedUsingTag.Count > i)
                    {
                        finalMoviesId.Add(moviesIdRecommendedUsingTag[i]);
                    }
                    else
                    {
                        if(moviesIdRecommendedUsingTitle != null && moviesIdRecommendedUsingTitle.Count > i)
                        {
                            finalMoviesId.Add(moviesIdRecommendedUsingTitle[i]);
                        }
            
                    }
                    
                } else
                {
                    if(moviesIdRecommendedUsingTitle != null && moviesIdRecommendedUsingTitle.Count > i)
                    {
                        finalMoviesId.Add(moviesIdRecommendedUsingTitle[i]);
                    }
                    else
                    {
                        if(moviesIdRecommendedUsingTag != null && moviesIdRecommendedUsingTag.Count > i)
                        {
                            finalMoviesId.Add(moviesIdRecommendedUsingTag[i]);
                        }
                        
                    }

                }
            }
            return finalMoviesId;
        }

        public static List<int> RecommendedMoviesIdByTag(float userId, List<int> moviesId)
        {

            SortedList<float, float> predictions = new SortedList<float, float>();
            for (int i = 0; i < moviesId.Count/2; i++)
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
            for (int i = 0; i < moviesId.Count/2; i++)
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
            var sortedPredictions = predictions.OrderBy(r => r.Value);
            moviesId.Clear();
            foreach (KeyValuePair<float, float> prediction in sortedPredictions)
            {
                moviesId.Add((int)prediction.Key);
            }
            return moviesId;
        }
    }
}

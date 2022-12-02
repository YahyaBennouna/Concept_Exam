/***********************************************************************
 * Module:  Quest.cs
 * Author:  benn
 * Purpose: Definition of the Class Quest
 ***********************************************************************/

using System;

public class Quest
{
   public System.Collections.ArrayList reponse;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetReponse()
   {
      if (reponse == null)
         reponse = new System.Collections.ArrayList();
      return reponse;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetReponse(System.Collections.ArrayList newReponse)
   {
      RemoveAllReponse();
      foreach (Reponse oReponse in newReponse)
         AddReponse(oReponse);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddReponse(Reponse newReponse)
   {
      if (newReponse == null)
         return;
      if (this.reponse == null)
         this.reponse = new System.Collections.ArrayList();
      if (!this.reponse.Contains(newReponse))
         this.reponse.Add(newReponse);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveReponse(Reponse oldReponse)
   {
      if (oldReponse == null)
         return;
      if (this.reponse != null)
         if (this.reponse.Contains(oldReponse))
            this.reponse.Remove(oldReponse);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllReponse()
   {
      if (reponse != null)
         reponse.Clear();
   }
   public System.Collections.ArrayList evaluation;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetEvaluation()
   {
      if (evaluation == null)
         evaluation = new System.Collections.ArrayList();
      return evaluation;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetEvaluation(System.Collections.ArrayList newEvaluation)
   {
      RemoveAllEvaluation();
      foreach (Evaluation oEvaluation in newEvaluation)
         AddEvaluation(oEvaluation);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddEvaluation(Evaluation newEvaluation)
   {
      if (newEvaluation == null)
         return;
      if (this.evaluation == null)
         this.evaluation = new System.Collections.ArrayList();
      if (!this.evaluation.Contains(newEvaluation))
         this.evaluation.Add(newEvaluation);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveEvaluation(Evaluation oldEvaluation)
   {
      if (oldEvaluation == null)
         return;
      if (this.evaluation != null)
         if (this.evaluation.Contains(oldEvaluation))
            this.evaluation.Remove(oldEvaluation);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllEvaluation()
   {
      if (evaluation != null)
         evaluation.Clear();
   }

   private int NombrePoint;

}
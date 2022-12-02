/***********************************************************************
 * Module:  Reponse.cs
 * Author:  benn
 * Purpose: Definition of the Class Reponse
 ***********************************************************************/

using System;

public class Reponse
{
   public Boolean QuestVerification()
   {
      // TODO: implement
      return null;
   }

   public System.Collections.ArrayList degreCertitude;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetDegreCertitude()
   {
      if (degreCertitude == null)
         degreCertitude = new System.Collections.ArrayList();
      return degreCertitude;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetDegreCertitude(System.Collections.ArrayList newDegreCertitude)
   {
      RemoveAllDegreCertitude();
      foreach (DegreCertitude oDegreCertitude in newDegreCertitude)
         AddDegreCertitude(oDegreCertitude);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddDegreCertitude(DegreCertitude newDegreCertitude)
   {
      if (newDegreCertitude == null)
         return;
      if (this.degreCertitude == null)
         this.degreCertitude = new System.Collections.ArrayList();
      if (!this.degreCertitude.Contains(newDegreCertitude))
         this.degreCertitude.Add(newDegreCertitude);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveDegreCertitude(DegreCertitude oldDegreCertitude)
   {
      if (oldDegreCertitude == null)
         return;
      if (this.degreCertitude != null)
         if (this.degreCertitude.Contains(oldDegreCertitude))
            this.degreCertitude.Remove(oldDegreCertitude);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllDegreCertitude()
   {
      if (degreCertitude != null)
         degreCertitude.Clear();
   }

   private Char Choix;

}
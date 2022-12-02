/***********************************************************************
 * Module:  MultiReponse.cs
 * Author:  benn
 * Purpose: Definition of the Class MultiReponse
 ***********************************************************************/

using System;

public class MultiReponse
{
   public System.Collections.ArrayList choix;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetChoix()
   {
      if (choix == null)
         choix = new System.Collections.ArrayList();
      return choix;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetChoix(System.Collections.ArrayList newChoix)
   {
      RemoveAllChoix();
      foreach (Choix oChoix in newChoix)
         AddChoix(oChoix);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddChoix(Choix newChoix)
   {
      if (newChoix == null)
         return;
      if (this.choix == null)
         this.choix = new System.Collections.ArrayList();
      if (!this.choix.Contains(newChoix))
         this.choix.Add(newChoix);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveChoix(Choix oldChoix)
   {
      if (oldChoix == null)
         return;
      if (this.choix != null)
         if (this.choix.Contains(oldChoix))
            this.choix.Remove(oldChoix);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllChoix()
   {
      if (choix != null)
         choix.Clear();
   }

}
/***********************************************************************
 * Module:  Qcm.cs
 * Author:  benn
 * Purpose: Definition of the Class Qcm
 ***********************************************************************/

using System;

public class Qcm
{
   public System.Collections.ArrayList quest;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetQuest()
   {
      if (quest == null)
         quest = new System.Collections.ArrayList();
      return quest;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetQuest(System.Collections.ArrayList newQuest)
   {
      RemoveAllQuest();
      foreach (Quest oQuest in newQuest)
         AddQuest(oQuest);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddQuest(Quest newQuest)
   {
      if (newQuest == null)
         return;
      if (this.quest == null)
         this.quest = new System.Collections.ArrayList();
      if (!this.quest.Contains(newQuest))
         this.quest.Add(newQuest);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveQuest(Quest oldQuest)
   {
      if (oldQuest == null)
         return;
      if (this.quest != null)
         if (this.quest.Contains(oldQuest))
            this.quest.Remove(oldQuest);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllQuest()
   {
      if (quest != null)
         quest.Clear();
   }
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

   private int NbrQuest;

}
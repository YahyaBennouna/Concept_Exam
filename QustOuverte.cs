/***********************************************************************
 * Module:  QustOuverte.cs
 * Author:  benn
 * Purpose: Definition of the Class QustOuverte
 ***********************************************************************/

using System;

public class QustOuverte
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

   private int NbrQuest;

}
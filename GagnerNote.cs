/***********************************************************************
 * Module:  GagnerNote.cs
 * Author:  benn
 * Purpose: Definition of the Class GagnerNote
 ***********************************************************************/

using System;

public class GagnerNote
{
   public void NoteGagne()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList noteFinal;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetNoteFinal()
   {
      if (noteFinal == null)
         noteFinal = new System.Collections.ArrayList();
      return noteFinal;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetNoteFinal(System.Collections.ArrayList newNoteFinal)
   {
      RemoveAllNoteFinal();
      foreach (NoteFinal oNoteFinal in newNoteFinal)
         AddNoteFinal(oNoteFinal);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddNoteFinal(NoteFinal newNoteFinal)
   {
      if (newNoteFinal == null)
         return;
      if (this.noteFinal == null)
         this.noteFinal = new System.Collections.ArrayList();
      if (!this.noteFinal.Contains(newNoteFinal))
         this.noteFinal.Add(newNoteFinal);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveNoteFinal(NoteFinal oldNoteFinal)
   {
      if (oldNoteFinal == null)
         return;
      if (this.noteFinal != null)
         if (this.noteFinal.Contains(oldNoteFinal))
            this.noteFinal.Remove(oldNoteFinal);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllNoteFinal()
   {
      if (noteFinal != null)
         noteFinal.Clear();
   }

   private float NoteGagne;

}
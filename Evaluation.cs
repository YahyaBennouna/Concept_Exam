/***********************************************************************
 * Module:  Evaluation.cs
 * Author:  benn
 * Purpose: Definition of the Class Evaluation
 ***********************************************************************/

using System;

public class Evaluation
{
   public System.Collections.ArrayList etudiant;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetEtudiant()
   {
      if (etudiant == null)
         etudiant = new System.Collections.ArrayList();
      return etudiant;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetEtudiant(System.Collections.ArrayList newEtudiant)
   {
      RemoveAllEtudiant();
      foreach (Etudiant oEtudiant in newEtudiant)
         AddEtudiant(oEtudiant);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddEtudiant(Etudiant newEtudiant)
   {
      if (newEtudiant == null)
         return;
      if (this.etudiant == null)
         this.etudiant = new System.Collections.ArrayList();
      if (!this.etudiant.Contains(newEtudiant))
         this.etudiant.Add(newEtudiant);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveEtudiant(Etudiant oldEtudiant)
   {
      if (oldEtudiant == null)
         return;
      if (this.etudiant != null)
         if (this.etudiant.Contains(oldEtudiant))
            this.etudiant.Remove(oldEtudiant);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllEtudiant()
   {
      if (etudiant != null)
         etudiant.Clear();
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

   private int DateDebut;
   private int DateFin;

}
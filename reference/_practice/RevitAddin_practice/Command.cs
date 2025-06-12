#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

#endregion

namespace RevitAddin_practice
{
  [Transaction(TransactionMode.Manual)]
  public class Command : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements)
    {
      UIApplication uiapp = commandData.Application;
      UIDocument uidoc = uiapp.ActiveUIDocument;
      Application app = uiapp.Application;
      Document doc = uidoc.Document;


      #region Step-4
      //Reference r = uidoc.Selection.PickObject(ObjectType.Element);
      //Element e = doc.GetElement(r.ElementId);
      //Wall wall = e as Wall;

      //TaskDialog.Show("¾Ë¸²", wall.Name);
      #endregion

      #region Step-5
      IList<Reference> rf = uidoc.Selection.PickObjects(ObjectType.Element);
      List<Wall> walls = new List<Wall>();

      foreach (Reference item in rf)
      {
        Element wall = doc.GetElement(item.ElementId);
        Wall w = wall as Wall;
        walls.Add(w);
      }

      for (int i = 0; i < rf.Count; i++)
      {
        string name = walls[i].Name;
      }

      #endregion


      return Result.Succeeded;
    }
  }
}

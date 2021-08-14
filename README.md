# UnityCUP
Custom Update Pipeline project for Unity3d

You can optimise(~40%) your Unity project with it 

Just replace:
MonuBehaviour -> ChronoBehaviour
"void Update" -> "override void ChronoUpdate()"
"void FixedUpdate" -> "override void ChronoFixedUpdate()"
"void Start" -> "ChronoStart"

Add to ChronoStart:
        Chronos.Main.AddUpdate(ChronoUpdate);        
        Chronos.Main.AddFixedUpdate(ChronoUpdate);
        
Add to OnDestroy:
        Chronos.Main.RemoveUpdate(ChronoUpdate);
        Chronos.Main.RemoveFixedUpdate(ChronoUpdate);

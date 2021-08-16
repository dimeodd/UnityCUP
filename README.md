# UnityCUP
Custom Unity Pause<br>
"Pause the game without timeScale"

Include optimisation(~40%) for your Unity project

Just replace:<br>
MonoBehaviour -> ChronoBehaviour<br>
"void Update" -> "override void ChronoUpdate()"<br>
"void FixedUpdate" -> "override void ChronoFixedUpdate()"<br>
"void Start" -> "ChronoStart"

Add to ChronoStart:<br>
Chronos.Main.AddUpdate(ChronoUpdate);<br>
Chronos.Main.AddFixedUpdate(ChronoUpdate);
        
Add to OnDestroy:<br>
Chronos.Main.RemoveUpdate(ChronoUpdate);<br>
Chronos.Main.RemoveFixedUpdate(ChronoUpdate);

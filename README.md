# UnityCUP
Custom Unity Pause<br>
<i>Pause the game without timeScale</i>

Include optimisation(~40%) for your Unity project

Just replace:<br>
MonoBehaviour -> ChronoBehaviour<br>
"void Update" -> "override void ChronoUpdate()"<br>
"void FixedUpdate" -> "override void ChronoFixedUpdate()"<br>
"void Start" -> "override void ChronoStart"

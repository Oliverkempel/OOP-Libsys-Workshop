# Verb noun analysis of Program specification

Verb = **bold**
Noun = <u>Underlined</u>

Sønderborg’s <u>library</u> **aims** to **launch** a digital <u>platform</u> to **manage** and **share** its diverse digital <u>media</u> <u>collection</u>. The <u>system</u> should **support** multiple <u>types</u> of <u>media</u>, **including**:

I <u>E‑books</u> with <u>information</u> about their <u>title</u>, <u>author</u>, <u>language</u>, <u>number</u> of <u>pages</u>, <u>year</u> of <u>publication</u> and <u>ISBN</u>. <u>Users</u> can **view**, **download** and **read** them.
I <u>Movies</u> with <u>information</u> about their <u>title</u>, <u>director</u>, <u>genres</u>, <u>release</u> <u>year</u>, <u>language</u> and <u>duration</u>. <u>Users</u> can **watch** and **download** them.
I <u>Songs</u> with <u>information</u> about their <u>title</u>, <u>composer</u>, <u>singer</u>, <u>genre</u>, <u>file</u> <u>type</u>, <u>duration</u> and <u>language</u>. <u>Users</u> can **play** and **download** them.
I <u>Video‑games</u> with <u>information</u> about their <u>title</u>, <u>genre</u>, <u>publisher</u>, <u>release</u> <u>year</u> and **supported** <u>platforms</u>. <u>Users</u> can **download**, **play** and eventually **complete** them.
I <u>Apps</u> with <u>information</u> about their <u>title</u>, <u>version</u>, <u>publisher</u>, **supported** <u>platforms</u> and <u>file</u> <u>size</u>. <u>Users</u> can **download** and **execute** them
I <u>Podcasts</u> with <u>information</u> about their <u>title</u>, <u>release</u> <u>year</u>, <u>host(s)</u>, <u>guest(s)</u>, <u>episode</u> <u>number</u> and <u>language</u>. <u>Users</u> can **download** and **listen** to an <u>episode</u> and **complete** it.
I <u>Images</u> with <u>information</u> about their <u>title</u>, <u>resolution</u>, <u>file</u> <u>format</u>, <u>file</u> <u>size</u> and <u>date</u> **taken**. <u>Users</u> can **download** and **display** an <u>image</u>

<u>Users</u> should be able to **borrow** all <u>media</u> <u>items</u>, and only <u>users</u> who have **borrowed** an <u>item</u> may **rate** it.

The <u>system</u> must also **support** two <u>categories</u> of <u>users</u>: <u>Admin</u>, <u>Employee</u> and <u>Borrower</u>. For each of these the <u>system</u> needs to **know** the <u>name</u>, <u>age</u> and <u>social</u> <u>security</u> <u>number</u>. As a starting <u>point</u>, <u>user</u> <u>authentication</u> is not **required**. However on <u>startup</u>, the <u>program</u> should **ask** the <u>user</u> to **identify** their <u>role</u>.

I <u>Borrower</u> **interact** with the <u>collection</u> by **listing** <u>items</u> by <u>type</u>, **selecting** and **previewing** <u>details</u>, **rating** <u>items</u>, and **performing** <u>actions</u> specific to the <u>media</u> <u>type</u>.
I <u>Employee</u> is responsible for **managing** the <u>collection</u> with the <u>ability</u> to **add** or **remove** <u>media</u> <u>items</u>
I <u>Admin</u> has all of an <u>Employee’s</u> <u>rights</u> and can additionally **manage** <u>Borrowers</u> and <u>Employees</u>. <u>Management</u> covers **viewing**, **creating**, **deleting**, **updating** the personal <u>information</u> of <u>users</u>.

The **supported** <u>actions</u> should be **made** available to all <u>user</u> <u>categories</u> in a clear and structured <u>way</u>.

The <u>console</u> <u>interface</u> should **guide** the <u>user</u> with clear <u>instructions</u> and **validate** all <u>inputs</u>. <u>Errors</u> or invalid <u>actions</u> should not **pass** this <u>filter</u>. The <u>design</u> should **anticipate** <u>growth</u> through <u>extensibility</u>, **ensuring** that new <u>media</u> <u>types</u> or <u>user</u> <u>roles</u> can be **added** without **disrupting** existing <u>functionality</u>.

|Potential Classes (Verbs)|
|-----|
|Libaray|
|Media|
|MediaType|
|E-Book|
|Movie|
|Song|
|Videogame|
|App|
|Podcarst|
|Picture|
|Information|
|Director|
|Genre|
|User|
|Composer|
|Singer|
|Filetype|
|Platform|
|Version|
|**Media Item**|
|Admin|
|Empoyee|
|Borrorer|
|User Inrterface|
|Details|
|Actions|
|Console interface|
|Instruction|
|Filter|
|User roles|

|Potential Methods (Nouns)|
|-----|
||
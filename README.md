# WSchris hola estimado usuario 
mi codigo fuente de mi proyecto  espero le guste

Alumno@SJM020308 MINGW64 ~
$ git
usage: git [--version] [--help] [-C <path>] [-c <name>=<value>]
           [--exec-path[=<path>]] [--html-path] [--man-path] [--info-path]
           [-p | --paginate | -P | --no-pager] [--no-replace-objects] [--bare]
           [--git-dir=<path>] [--work-tree=<path>] [--namespace=<name>]
           <command> [<args>]

These are common Git commands used in various situations:

start a working area (see also: git help tutorial)
   clone     Clone a repository into a new directory
   init      Create an empty Git repository or reinitialize an existing one

work on the current change (see also: git help everyday)
   add       Add file contents to the index
   mv        Move or rename a file, a directory, or a symlink
   restore   Restore working tree files
   rm        Remove files from the working tree and from the index

examine the history and state (see also: git help revisions)
   bisect    Use binary search to find the commit that introduced a bug
   diff      Show changes between commits, commit and working tree, etc
   grep      Print lines matching a pattern
   log       Show commit logs
   show      Show various types of objects
   status    Show the working tree status

grow, mark and tweak your common history
   branch    List, create, or delete branches
   commit    Record changes to the repository
   merge     Join two or more development histories together
   rebase    Reapply commits on top of another base tip
   reset     Reset current HEAD to the specified state
   switch    Switch branches
   tag       Create, list, delete or verify a tag object signed with GPG

collaborate (see also: git help workflows)
   fetch     Download objects and refs from another repository
   pull      Fetch from and integrate with another repository or a local branch
   push      Update remote refs along with associated objects

'git help -a' and 'git help -g' list available subcommands and some
concept guides. See 'git help <command>' or 'git help <concept>'
to read about a specific subcommand or concept.
See 'git help git' for an overview of the system.


Alumno@SJM020308 MINGW64 ~/Desktop/webservices
$ ls
WcfService1/  webservices.sln

Alumno@SJM020308 MINGW64 ~/Desktop/webservices
$ pwd
/c/Users/Alumno/Desktop/webservices

Alumno@SJM020308 MINGW64 ~/Desktop/webservices
$ ls
WcfService1/  webservices.sln

Alumno@SJM020308 MINGW64 ~/Desktop/webservices
$ git init
Initialized empty Git repository in C:/Users/Alumno/Desktop/webservices/.git/

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git status
On branch master

No commits yet

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        .vs/
        WcfService1/
        webservices.sln

nothing added to commit but untracked files present (use "git add" to track)

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git add webservices.sln

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git add WcfService1/

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git commit

*** Please tell me who you are.

Run

  git config --global user.email "you@example.com"
  git config --global user.name "Your Name"

to set your account's default identity.
Omit --global to set the identity only in this repository.

fatal: unable to auto-detect email address (got 'Alumno@SJM020308.(none)')

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ ^C

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git config --global user.email "christophercalderonsalomon99@gmail.com"

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$   git config --global user.name "Your Name"

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git config --global user.name "christopher"

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git commit -m "subiendo mi codigo"
[master (root-commit) 70ed4ee] subiendo mi codigo
 22 files changed, 430 insertions(+)
 create mode 100644 WcfService1/IService1.cs
 create mode 100644 WcfService1/Properties/AssemblyInfo.cs
 create mode 100644 WcfService1/Service1.svc
 create mode 100644 WcfService1/Service1.svc.cs
 create mode 100644 WcfService1/WcfService1.csproj
 create mode 100644 WcfService1/WcfService1.csproj.user
 create mode 100644 WcfService1/Web.Debug.config
 create mode 100644 WcfService1/Web.Release.config
 create mode 100644 WcfService1/Web.config
 create mode 100644 WcfService1/bin/WcfService1.dll
 create mode 100644 WcfService1/bin/WcfService1.dll.config
 create mode 100644 WcfService1/bin/WcfService1.pdb
 create mode 100644 WcfService1/obj/Debug/CoreCompileInputs.cache
 create mode 100644 WcfService1/obj/Debug/DesignTimeResolveAssemblyReferencesInput.cache
 create mode 100644 WcfService1/obj/Debug/TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
 create mode 100644 WcfService1/obj/Debug/TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
 create mode 100644 WcfService1/obj/Debug/TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
 create mode 100644 WcfService1/obj/Debug/WcfService1.csproj.FileListAbsolute.txt
 create mode 100644 WcfService1/obj/Debug/WcfService1.csprojResolveAssemblyReference.cache
 create mode 100644 WcfService1/obj/Debug/WcfService1.dll
 create mode 100644 WcfService1/obj/Debug/WcfService1.pdb
 create mode 100644 webservices.sln

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git remote add origin https://github.com/S0p0rt31/WSchris.git

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git push -u origin master
Logon failed, use ctrl+c to cancel basic credential prompt.
To https://github.com/S0p0rt31/WSchris.git
 ! [rejected]        master -> master (fetch first)
error: failed to push some refs to 'https://github.com/S0p0rt31/WSchris.git'
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git pull origin --rebase
warning: no common commits
remote: Enumerating objects: 6, done.
remote: Counting objects: 100% (6/6), done.
remote: Compressing objects: 100% (3/3), done.
remote: Total 6 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (6/6), done.
From https://github.com/S0p0rt31/WSchris
 * [new branch]      master     -> origin/master
You asked to pull from the remote 'origin', but did not specify
a branch. Because this is not the default configured remote
for your current branch, you must specify a branch on the command line.

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git pull origin master --rebase
From https://github.com/S0p0rt31/WSchris
 * branch            master     -> FETCH_HEAD
First, rewinding head to replay your work on top of it...
Applying: subiendo mi codigo

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$ git push -u origin master
Enumerating objects: 25, done.
Counting objects: 100% (25/25), done.
Delta compression using up to 8 threads
Compressing objects: 100% (20/20), done.
Writing objects: 100% (24/24), 13.04 KiB | 1.30 MiB/s, done.
Total 24 (delta 2), reused 0 (delta 0)
remote: Resolving deltas: 100% (2/2), done.
To https://github.com/S0p0rt31/WSchris.git
   fd55754..a369197  master -> master
Branch 'master' set up to track remote branch 'master' from 'origin'.

Alumno@SJM020308 MINGW64 ~/Desktop/webservices (master)
$

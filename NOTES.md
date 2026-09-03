<<<   Assignment 1.1   >>>
<<< Question 1 >>>
A - The kinds of changes that deserve their own atomic commit for me would be the main method or program or entry point, 
adding the team data file, connecting the program to the team data, adding the search. So would put each meaningful 
change into its own commit. I'd also want to be able to revert back with ease to the last working project.

B - Commits that should be bundled together should be something that doesn't really have a meaningful effect, such as a
typo or a whitespace or even a console.log that I added and then removed in the same sitting. The extra commits don't 
really have useful information. These small changes will give my co-workers or people working on my project extra 
unneccessary work that takes time. It also makes the history more cluttered. 

C - .env might have secrets or configurations that should be kept a secret. *.log are files are made by the program
and don't have any useful parts of code.

<<< Question 2 >>>
Merge: preserves the branching history and shows where histories joined.
Rebase: sacrifices or re-writes the original branch history to produce a cleaner, linear history.
I would choose merge for the intentional conflict because I want the conflict resolution to be visible in the history 
and I want to preserve evidence that the branches developed separately before being combined.

<<< Question 3 >>>
git push  -> sends local commits/changes to GitHub
git fetch -> downloads information/commits from GitHub without integrating them
git pull  -> downloads changes from GitHub and integrates them locally
A successful git push does not mean that the code works correctly, that the project requirements have been met, or 
that tests pass. It only confirms that the remote repository accepted the pushed Git updates.

<<< Question 4 >>>
A: Fixed stuff -> Its bad because its too vague and doesn't explain what actually changed. A better commit message would 
be something like "Display all team members" because it explains what was added or changed.

B: Update index.js -> Its bad because it's too vague. It tells us which file was updated but doesn't explain what was 
actually changed. A better commit message would be something like "Add team member search to Update index.js"

C: WIP -> Bad because it doesn't explain what work was actually done in the commit.
A better message would be "Add team data loading"

D: Add email format validation so invalid addresses cannot be submitted -> It describes the solution well but its way 
long. A better message would be "Validate email format before submission"

E: asdasd -> Bad because it has no clear meaning and doesn't explain what was changed. A better message would be: Add 
team member sorting"

F: Changed line 47 of notes.md -> Bad because line 47 could change in the future and the message doesn't explain what was 
actually changed. A better message would be "Clarify public members"



=============================================================================================================================



<<< Part 3 >>>
Task 4: The feature/add-search branch was merged into main using a fast-forward merge. I could tell because Git moved 
main directly to the latest feature commit without creating a separate merge commit. (This one I didn't know, I had AI
tell me this but don't understand it still)

Task 9: I rebased feature/add-count onto the latest main, which replayed the feature commit on top of the updated main branch and gave it a new commit hash. I then merged the branch using a fast-forward merge. Unlike the earlier conflict merge, this produced a straight, linear history instead of another branch diamond.

<<< Part 4 >>>
Testing rejected push recovery.




=============================================================================================================================
=============================================================================================================================
=============================================================================================================================

<<< Assignment 1.2 >>>
<<<   Question 1   >>>

We fork because the project doesn't belong to us and we don't have permission to push changes directly to it. By forking, I create my own copy of the repository on GitHub, where I can create branches and push my changes. If I only cloned my partner's repository and tried to push a branch directly to it, the push would be rejected because I don't have write access. Instead, I can push the changes to my fork and create a pull request for the owner to review and accept.



<<<   Question 2   >>>
A bad description would be something like "Added role search. It works now." Its very vague and can be difficult for someone else working
on the project to find these changes. A better description should rather answer the questions of:
-> what: what did I change?
-> why: why was the change needed or useful?
-> how to verify: what can the reviewer do to check that it works?
So something like this: 
What: Added the ability to search for team members by their role.
Why: This makes it easier to find team members who have a specific role instead of looking through the entire list.
How to verify: Run the program, search for an existing role, and confirm that only team members with that role are displayed. 
Also search for a role that doesn't exist and confirm the program handles it correctly.
The second description is easier to review because it clearly explains what was changed, why the change was made, and gives the reviewer 
steps they can follow to test that the feature works correctly.

<<<   Question 3   >>>
Question is about the reviewer wanting clarification 
about something. and the suggestion is the reviewer giving an improvement (suggestion) for something that needs a change or improvement
when merging.
Nit or suggestion — a small improvement or preference that doesn't need to prevent the merge. For example, renaming string n to string name,
it doesn't fix something that was broken, but imrpoves the readability.
Blocking - there is a real problem that should be fixed before merging and would cause the code to break or conflict.

My rule: If the comment points out something that breaks the program or causes it to behave incorrectly, I would treat it as blocking. If the code still works but could be improved, I would treat it as a nit or suggestion. If the reviewer is asking for clarification about something, I would treat it as a question.

Google Answer: Blocking: A blocking comment is when the reviewer finds a problem that needs to be fixed before the code should be merged, such as something that breaks the program or causes it to behave incorrectly.
Nit or suggestion: A small improvement or preference that doesn't need to prevent the merge. For example, renaming `string n` to `string name`. It doesn't fix something that was broken, but improves readability.
Question: A question is when the reviewer wants clarification about something in the code.

<<<   Question 4   >>>
git fetch
GitHub - downloads information about new commits BUT doesn't change your local main

git pull
GitHub - downloads new commits AND integrates them into your current branch

Fetch allows you to view the code and changes made before making or implementing those changes already on your computer or branch. This is ideal if you aren't sure how the new code will behave with yours and that you don't make concrete changes to your code blindly.
Pull allows you to download those changes and already intergrate them into your code, for example, if you know the code works with yours because it already works with other employees that had the same version or code, you don't need to first view it, you can just pull it directly.


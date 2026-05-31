## Answering to: Briefly explain in the README why this merge was not fast-forward? 

This merge was not a fast-forward merge because the histories of the main branch and the feature-max branch had diverged. A fast-forward merge is only possible when the target branch (main) has no new commits since the feature branch was created

## Answering to: Briefly compare the visible effect of merge and rebase? 

Merge keeps the branches visible and adds a merge commit.
Rebase rewrites your commits so the history looks like one continuous line.


# 3 Short Questions from last part of task

### 1. When does Git perform a fast-forward and when is a merge commit created?
* **Fast-forward merge:** Occurs when there is a linear path from the current branch tip to the target branch. If the `main` branch has not received any new commits since you created your feature branch, Git simply moves the `main` pointer forward to match the feature branch. No new commit is created.
* **Merge commit:** Created when the branch histories have diverged. If both `main` and your feature branch have new, independent commits since they split, Git must perform a 3-way merge and create a brand-new "merge commit" to tie the two histories together.

### 2. What is the practical difference between merge and rebase?
* **Merge:** Preserves the exact chronological history of how features were developed. It is non-destructive and clearly shows where branches split and joined via merge commits. However, frequent merging can make the Git graph look complex and cluttered.
* **Rebase:** Rewrites project history by moving the entire feature branch so it begins at the tip of the latest `main` commit. This creates a perfectly flat, linear history that looks like all work happened sequentially. The downside is that it alters commit hashes, which can be dangerous if done on public, shared branches.

### 3. How was the conflict resolved in your repository?
A merge conflict occurred in `apbd1/StatisticsHelper.cs` because both branches modified the `CalculateMode` method simultaneously (`main` used an old-school `Dictionary` approach, while `feature-conflict` used a `LINQ` implementation). 

The conflict was resolved through the following steps:
1. The file `apbd1/StatisticsHelper.cs` was opened in Visual Studio.
2. The Git conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`) were cleaned up.
3. The newer **LINQ-based implementation** from the feature branch was chosen as the definitive solution.
4. The resolved file was staged using `git add apbd1/StatisticsHelper.cs`.
5. The merge was finalized by `git commit -m "Resolve merge conflict in StatisticsHelper - choose linq approach as new one"`
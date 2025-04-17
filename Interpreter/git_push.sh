#!/bin/bash



# Add all changes to the staging area
git add .




echo "Enter a commit message :"
read commitMsg
git commit -m "$commitMsg"



git push -u origin main
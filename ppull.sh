#!/bin/bash

git config --global user.name kihoonkwon
git config --global user.email jhgfjhgfjhgf96@gmail.com
echo "git pull run? [y/n]"

read answer

if [[ "$answer" == "y" ]]; then
    git pull
    echo "git pull completed"
else
    echo "git pull canceled"
fi

sleep 3

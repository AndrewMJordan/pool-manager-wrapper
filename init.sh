#!/usr/bin/env bash

read -p 'Package Name: ' packageName
read -p 'Author: ' author

sed -i "s/<AUTHOR>/$author/g" LICENSE
sed -i "s/<AUTHOR>/$author/g" preamble.txt
git mv "Project" "$packageName"
sed -i "s/productName: Test Package/productName: $packageName/g" "$packageName/ProjectSettings/ProjectSettings.asset"
git mv "$packageName/Assets/Package" "$packageName/Assets/$packageName"
git mv "$packageName/Assets/Package.meta" "$packageName/Assets/$packageName.meta"

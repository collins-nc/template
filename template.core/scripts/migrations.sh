#!/bin/bash
#
# Create a new migration
# Usage: ./scripts/migrations/new.sh <Migration Name>

#allow execution of script by all users 
#chmod a+x ./scripts/migrations/new.sh

# Exit on first error
set -e  
# Echo commands
set -x

MIGRATION_NAME=${1:?"Missing argument EF_DB_MIGRATION_NAME"}
EF_COMMAND="--project ./template.core.csproj --context AppDbContext --startup-project ../template.web/template.web.csproj"

dotnet ef migrations add $MIGRATION_NAME $EF_COMMAND 
dotnet ef database update $EF_COMMAND

 
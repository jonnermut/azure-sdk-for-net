set -ex

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null 2>&1 && pwd )"
SOURCE="https://nuget.bigtincan.net/v3/index.json"


CONFIG=Debug
SLN=.
PROJECT=/Azure.AI.OpenAI
APIKEY=""
OUTDIR=$SCRIPT_DIR/../../../artifacts/packages/$CONFIG/Azure.AI.OpenAI

rm -f "$OUTDIR/*.nupkg"
dotnet pack "src/Azure.AI.OpenAI.csproj" --configuration $CONFIG --include-symbols --include-source

dotnet nuget push -s "${SOURCE}" $OUTDIR/*.nupkg --skip-duplicate ${APIKEY}

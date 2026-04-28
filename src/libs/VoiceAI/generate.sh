#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -fsSL -o openapi.yaml https://voice.ai/docs/openapi.json
autosdk generate openapi.yaml \
  --namespace VoiceAI \
  --clientClassName VoiceAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

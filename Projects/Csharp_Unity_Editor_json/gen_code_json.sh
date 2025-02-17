#!/bin/zsh
WORKSPACE=../..

GEN_CLIENT=${WORKSPACE}/Tools/Luban.Client/Luban.Client.dll
CONF_ROOT=${WORKSPACE}/DesignerConfigs


dotnet ${GEN_CLIENT} -h ${LUBAN_SERVER_IP} -j cfg --\
 -d ${CONF_ROOT}/Defines/__root__.xml \
 --input_data_dir ${CONF_ROOT}/Datas \
 --output_code_dir Assets/Gen \
 --gen_types code_cs_unity_editor_json \
 -s all 

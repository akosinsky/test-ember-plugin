docker stack ls >NUL  2>NUL
IF %ERRORLEVEL% NEQ 0 (
	docker swarm init
)
docker stack deploy -c app-swarm-configuration.yml FlexberryAppProduct_23527

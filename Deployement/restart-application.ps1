# STOP DOCKER CONTAINER
docker stop $(docker ps -q)

#REMOVE IMAGE

docker rm $(docker ps -aq)

#REMOVE ANY USED VOLUMES

docker volume rm $(docker volume ls -q)

#Remove old images

  #docker image rm $(docker image ls -aq)

#restart the application 
docker compose build  --no-cache --parallel --force-rm
docker compose up
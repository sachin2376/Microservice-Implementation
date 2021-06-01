# Microservice-Implementation


I have implemented microservice demonstration in this !
Steps :-
  1. Created anasp.net web api as usual.
  2. After completion of whole web api, Added docker support to the project! Which caused the addition of dockerfile! Dosome changes to that as per in project!
  3. in terminal, run command => docker -t <microservicename> . // You can give any name that u want but it must be all lower letters.
  4. It will deploy that service in docker container! Now u can run that image as =>
          docker run -p 3000:80 --name -it --rm <ContainerName> <microservicename>
  5. Create a new asp.net mvc project and consume the microservice as per in project !

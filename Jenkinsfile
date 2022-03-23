pipeline{
    agent {label 'ubuntu'}
    parameters{ 
        string(name: 'Name', defaultValue: 'tapender')
    }
    stages{
      stage ('build-docker') {
         steps{
            sh '''
               mkdir -p tmp-dir
               docker build --pull -t ubuntu-dotnet:latest -f Dockerfile tmp-dir
            '''
         }
      }
        stage ('use-docker') {
            agent {
               docker{
                  image 'ubuntu-dotnet:latest'
               }
            }
            environment {
                HOME = '/tmp'
            }
            steps{
               sh 'dotnet build WebApplication'
               sh 'dotnet test WebApplication'
            }
        }
    }
}

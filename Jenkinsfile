pipeline{
    agent any

    stages{
        stage('Build'){
            steps{
                sh """cd ClientApp
                      npm install
                      npm run build-prod"""

            }
        }
        stage('Test'){
            steps{
                sh "echo 'Testing...'"
            }
        }
        stage('Deploy'){
            steps{
                sh """
                rm -rf /var/www/xbank-angular/dist
                cp -a ./ClientApp/dist/ /var/www/xbank-angular/dist"""
            }
        }
    }
}

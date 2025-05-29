#version 330 core
out vec3 FragColor;  
in vec3 vertexColor;
  
void main()
{
    FragColor = vertexColor;
}
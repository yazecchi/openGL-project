#version 330 core
out vec4 FragColor;

in vec4 out_color;
in vec2 tex_coord;

uniform sampler2D tex1;

void main(){
    FragColor = vec4(0.5f,0.5f,0.5f,1.0f);
}
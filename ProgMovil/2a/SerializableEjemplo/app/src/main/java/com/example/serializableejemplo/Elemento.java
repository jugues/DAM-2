package com.example.serializableejemplo;

public class Elemento {

    private int imgvFoto;
    private String titulo, contenido;

    public Elemento(int foto, String titulo, String contenido)
    {
        imgvFoto = foto;
        this.titulo = titulo;
        this.contenido = contenido;
    }

    public int getImgvFoto() {
        return imgvFoto;
    }

    public String getTitulo() {
        return titulo;
    }

    public String getContenido() {
        return contenido;
    }
}

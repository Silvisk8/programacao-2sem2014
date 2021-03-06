﻿using System.Collections.Generic;

public class Inventario
{
	// atributos
	public List<Item> itens;
	private int _capacidade;
	private int _pesoAtual;

	// construtor
	public Inventario(int pesoMaximo)
	{
		this._capacidade = pesoMaximo;
		this._pesoAtual = 0;
		this.itens = new List<Item>();
	}
	
	// propriedades
	public int PesoAtual
	{
		get
		{
			return _pesoAtual;
		}
	}
	
	public int Capacidade
	{
		get
		{
			return _capacidade;
		}
		
		set
		{
			while (_pesoAtual > value)
			{
				_pesoAtual -= itens [0].peso;
				itens.RemoveAt(0);
			}
			_capacidade = value;
		}
	}

	// metodos
	public bool Guardar(Item novo)
	{
		if (novo.peso + _pesoAtual > _capacidade)
		{
			return false;
		} else
		{
			_pesoAtual += novo.peso;
			itens.Add(novo);
			return true;
		}
	}
}







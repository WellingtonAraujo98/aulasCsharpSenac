using System;

namespace testePoo;

public class ContaBancaria
{
	public string NumeroConta;
	public string Nome;
	private double _saldo;
	

	ContaBancaria(string conta, string nome)
	{
		NumeroConta = conta;
		Nome = nome;
		_saldo = 0;
	}

}

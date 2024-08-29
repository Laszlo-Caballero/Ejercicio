
create or alter procedure InsertarPro
@COD char(5),
@DESC varchar(50),
@PRE money,
@STK_ACT int,
@STK_MIN int,
@MED varchar(30),
@IMP varchar(10)
as
begin
	insert into TB_PRODUCTO (COD_PRO, DES_PRO, PRE_PRO, STK_ACT, STK_MIN, UNI_MED, LIN_PRO, IMPORTADO)
	VALUES(@COD, @DESC,@PRE, @STK_ACT, @STK_MIN, @MED, 3, @IMP)
end

EXEC InsertarPro @COD, @DESC, @PRE, @STK_ACT, @STK_MIN, @MED, @IMP

go
create procedure Datos_Fac
@numfac varchar(12)
as
begin
select F.NUM_FAC, F.FEC_FAC, C.CONTACTO, C.RUC_CLI, C.RAZ_SOC_CLI, F.PORC_IGV from TB_FACTURA F 
inner join TB_CLIENTE C on C.COD_CLI = F.COD_CLI
inner join TB_DETALLE_FACTURA DF on DF.NUM_FAC= F.NUM_FAC
where F.NUM_FAC = @numfac
end

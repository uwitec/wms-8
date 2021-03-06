﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDocumentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;

namespace Dddml.Wms.Domain.DocumentType
{

	public static partial class DocumentTypeStateExtension
	{

        public static IDocumentTypeCommand ToCreateOrMergePatchDocumentType(this DocumentTypeState state)
        {
            return state.ToCreateOrMergePatchDocumentType<CreateDocumentType, MergePatchDocumentType>();
        }

        public static DeleteDocumentType ToDeleteDocumentType(this DocumentTypeState state)
        {
            return state.ToDeleteDocumentType<DeleteDocumentType>();
        }

        public static MergePatchDocumentType ToMergePatchDocumentType(this DocumentTypeState state)
        {
            return state.ToMergePatchDocumentType<MergePatchDocumentType>();
        }

        public static CreateDocumentType ToCreateDocumentType(this DocumentTypeState state)
        {
            return state.ToCreateDocumentType<CreateDocumentType>();
        }
		

	}

}

